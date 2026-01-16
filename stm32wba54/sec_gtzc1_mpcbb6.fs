\
\ @file sec_gtzc1_mpcbb6.fs
\ @brief GTZC1_MPCBB6 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MPCBB control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_CR_GLOCK            \ lock the control register of the MPCBB until next reset; This bit is cleared by default and once set, it can not be reset until system reset.
$40000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_CR_INVSECSTATE      \ SRAM clocks security state; This bit is used to define the internal SRAM clocks control in RCC as secure or not.
$80000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_CR_SRWILADIS        \ secure read/write illegal access disable; This bit disables the detection of an illegal access when a secure read/write transaction access a non-secure blocks of the block-based SRAM (secure fetch on non-secure block is always considered illegal).


\
\ @brief GTZC1 SRAMz MPCBB configuration lock register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_CFGLOCK_SPLCK0      \ Security/privilege configuration lock super-block; This bit is set by software and can be cleared only by system reset.; note that bit [3:2] are reserved on sales type STM32WBA5xEx for MPCBB1.


\
\ @brief GTZC1 MPCBB security configuration for super-block 0 register
\ Address offset: 0x100
\ Reset value: 0xFFFFFFFF
\

$00000001 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC0       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000002 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC1       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000004 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC2       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000008 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC3       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000010 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC4       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000020 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC5       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000040 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC6       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000080 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC7       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000100 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC8       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000200 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC9       \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000400 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC10      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000800 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC11      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00001000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC12      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00002000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC13      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00004000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC14      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00008000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC15      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00010000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC16      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00020000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC17      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00040000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC18      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00080000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC19      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00100000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC20      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00200000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC21      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00400000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC22      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00800000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC23      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$01000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC24      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$02000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC25      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$04000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC26      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$08000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC27      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$10000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC28      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$20000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC29      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$40000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC30      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$80000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0_SEC31      \ Security configuration for block y (y = 0 to 31) in super block n Unprivileged write to this bit is ignored if PRIVy bit is set in GTZC1_MPCBB_PRIVCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.


\
\ @brief GTZC1 MPCBB privileged configuration for super-block 0 register
\ Address offset: 0x200
\ Reset value: 0xFFFFFFFF
\

$00000001 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV0     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000002 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV1     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000004 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV2     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000008 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV3     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000010 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV4     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000020 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV5     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000040 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV6     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000080 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV7     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000100 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV8     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000200 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV9     \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000400 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV10    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00000800 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV11    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00001000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV12    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00002000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV13    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00004000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV14    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00008000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV15    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00010000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV16    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00020000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV17    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00040000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV18    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00080000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV19    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00100000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV20    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00200000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV21    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00400000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV22    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$00800000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV23    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$01000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV24    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$02000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV25    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$04000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV26    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$08000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV27    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$10000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV28    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$20000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV29    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$40000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV30    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.
$80000000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0_PRIV31    \ Privileged configuration for block y (y = 0 to 31), belonging to super-block n. Non-secure write to this bit is ignored if SECy bit is set in GTZC1_MPCBB_SECCFGRn. Writes are ignored if SPLCKn bit is set in GTZC1_MPCBB_CFGLOCK.


\
\ @brief GTZC1_MPCBB6 address block description
\
$50034000 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_CR  \ offset: 0x00 : MPCBB control register
$50034010 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_CFGLOCK  \ offset: 0x10 : GTZC1 SRAMz MPCBB configuration lock register
$50034100 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_SECCFGR0  \ offset: 0x100 : GTZC1 MPCBB security configuration for super-block 0 register
$50034200 constant SEC_GTZC1_MPCBB6_GTZC1_MPCBB_PRIVCFGR0  \ offset: 0x200 : GTZC1 MPCBB privileged configuration for super-block 0 register

