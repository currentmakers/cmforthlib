\
\ @file flash_ctrl.fs
\ @brief 4kb addressable space
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief COMMAND register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant FLASH_CTRL_COMMAND_COMMAND                       \ Macro commands for flash operations (may require DATA0...DATA3 to be set): - 0x11 : ERASE - 0x22 : MASSERASE - 0x33 : WRITE - 0x55 : MASSREAD - 0xAA : SLEEP - 0xBB : WAKEUP - 0xCC : BURSTWRITE - 0xEE : OTPWRITE - 0xFF : KEYWRITE


\
\ @brief CONFIG register
\ Address offset: 0x04
\ Reset value: 0x00000010
\

$00000002 constant FLASH_CTRL_CONFIG_REMAP                          \ Bit to redirect boot area on SRAM0.
$00000004 constant FLASH_CTRL_CONFIG_DIS_GROUP_WRITE                \ Burst write Control: - 0 : burst write allowed - 1 : burst write forbidden
$00000030 constant FLASH_CTRL_CONFIG_WAIT_STATES                    \ Number of wait states to be inserted on Flash read (AHB accesses)


\
\ @brief IRQSTAT register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant FLASH_CTRL_IRQSTAT_CMDDONE_MIS                   \ Command done masked interrupt status.
$00000002 constant FLASH_CTRL_IRQSTAT_CMDSTART_MIS                  \ Command started masked interrupt status.
$00000004 constant FLASH_CTRL_IRQSTAT_CMDERR_MIS                    \ Command error masked interrupt status.
$00000008 constant FLASH_CTRL_IRQSTAT_ILLCMD_MIS                    \ Illegal command masked interrupt status
$00000010 constant FLASH_CTRL_IRQSTAT_READOK_MIS                    \ Mass read OK masked interrupt status.


\
\ @brief IRQMASK register
\ Address offset: 0x0C
\ Reset value: 0x0000003F
\

$00000001 constant FLASH_CTRL_IRQMASK_CMDDONEM                      \ Command done mask
$00000002 constant FLASH_CTRL_IRQMASK_CMDSTARTM                     \ Command started mask.
$00000004 constant FLASH_CTRL_IRQMASK_CMDERRM                       \ Command error mask.
$00000008 constant FLASH_CTRL_IRQMASK_ILLCMDM                       \ Illegal command mask.
$00000010 constant FLASH_CTRL_IRQMASK_READOKM                       \ Mass read OK mask.


\
\ @brief IRQRAW register
\ Address offset: 0x10
\ Reset value: 0x00000001
\

$00000001 constant FLASH_CTRL_IRQRAW_CMDDONE_RIS                    \ Command done raw/unmasked interrupt status. This it is set once the requested command execution is completed. Cleared by writing 1.
$00000002 constant FLASH_CTRL_IRQRAW_CMDSTART_RIS                   \ Command started raw/unmasked interrupt status. This bit is set once the requested command execution has started.
$00000004 constant FLASH_CTRL_IRQRAW_CMDERR_RIS                     \ Command error raw/unmasked interrupt status
$00000008 constant FLASH_CTRL_IRQRAW_ILLCMD_RIS                     \ Illegal command raw/unmasked interrupt status.
$00000010 constant FLASH_CTRL_IRQRAW_READOK_RIS                     \ Mass read OK raw/unmasked interrupt status


\
\ @brief SIZE register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant FLASH_CTRL_SIZE_FLASH_SIZE                       \ Maximum valid address for flash memory: - 00 : 0x0BFFF (192kb) - 01 : 0x0FFFF (256kb) - 10 : 0x17FFF (384kb) - 11 : 0x1FFFF (512kb)
$00060000 constant FLASH_CTRL_SIZE_RAM_SIZE                         \ RAM memory size selection: - 00 : 32kb - 01 : 32kb - 10 : 48kb - 11 : 64kb
$00080000 constant FLASH_CTRL_SIZE_FLASH_SECURE                     \ Flash memory protection (0: no key present, 1: key present)
$00100000 constant FLASH_CTRL_SIZE_SWD_DISABLE                      \ Flash+SWD protection: 0: No SWD protection (refer to FLASH_SECURE) 1: Flash and SWD protected


\
\ @brief ADDRESS register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000003f constant FLASH_CTRL_ADDRESS_YADDR                         \ Flash column address offset to be used with some COMMAND
$0000ffc0 constant FLASH_CTRL_ADDRESS_XADDR                         \ Flash row address offset to be used with some COMMAND


\
\ @brief LFSRVAL register
\ Address offset: 0x24
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_LFSRVAL_LFSRVAL                       \ Flash read data CRC signature


\
\ @brief PAGEPROT0 register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_CTRL_PAGEPROT0_SEG0                        \ First segment definition.
$ffff0000 constant FLASH_CTRL_PAGEPROT0_SEG1                        \ Second segment definition. See SEG0 description for details on SEG1[31:16] content


\
\ @brief PAGEPROT1 register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_CTRL_PAGEPROT1_SEG2                        \ Third segment definition. See PAGEPROT0 SEG0 description for details on SEG2[15:0] content
$ffff0000 constant FLASH_CTRL_PAGEPROT1_SEG3                        \ Fourth segment definition. See PAGEPROT0 SEG0 description for details on SEG3[15:0] content.


\
\ @brief DATA0 register
\ Address offset: 0x40
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA0_DATA0                           \ Value to be used as DATA for any COMMAND of type WRITE and compare value for MASSREAD


\
\ @brief DATA1 register
\ Address offset: 0x44
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA1_DATA1                           \ Value to be used as DATA for any COMMAND of type WRITE


\
\ @brief DATA2 register
\ Address offset: 0x48
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA2_DATA2                           \ Value to be used as DATA for any COMMAND of type WRITE


\
\ @brief DATA3 register
\ Address offset: 0x4C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA3_DATA3                           \ Value to be used as DATA for any COMMAND of type WRITE


\
\ @brief 4kb addressable space
\
$40001000 constant FLASH_CTRL_COMMAND  \ offset: 0x00 : COMMAND register
$40001004 constant FLASH_CTRL_CONFIG  \ offset: 0x04 : CONFIG register
$40001008 constant FLASH_CTRL_IRQSTAT  \ offset: 0x08 : IRQSTAT register
$4000100c constant FLASH_CTRL_IRQMASK  \ offset: 0x0C : IRQMASK register
$40001010 constant FLASH_CTRL_IRQRAW  \ offset: 0x10 : IRQRAW register
$40001014 constant FLASH_CTRL_SIZE  \ offset: 0x14 : SIZE register
$40001018 constant FLASH_CTRL_ADDRESS  \ offset: 0x18 : ADDRESS register
$40001024 constant FLASH_CTRL_LFSRVAL  \ offset: 0x24 : LFSRVAL register
$40001034 constant FLASH_CTRL_PAGEPROT0  \ offset: 0x34 : PAGEPROT0 register
$40001038 constant FLASH_CTRL_PAGEPROT1  \ offset: 0x38 : PAGEPROT1 register
$40001040 constant FLASH_CTRL_DATA0  \ offset: 0x40 : DATA0 register
$40001044 constant FLASH_CTRL_DATA1  \ offset: 0x44 : DATA1 register
$40001048 constant FLASH_CTRL_DATA2  \ offset: 0x48 : DATA2 register
$4000104c constant FLASH_CTRL_DATA3  \ offset: 0x4C : DATA3 register

