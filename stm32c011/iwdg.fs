\
\ @file iwdg.fs
\ @brief IWDG register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief IWDG key register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant IWDG_IWDG_KR_KEY                                 \ Key value (write only, read 0x0000) These bits must be written by software at regular intervals with the key value 0xAAAA, otherwise the watchdog generates a reset when the counter reaches 0. Writing the key value 0x5555 to enable access to the IWDG_PR, IWDG_RLR and IWDG_WINR registers (see ) Writing the key value 0xCCCC starts the watchdog (except if the hardware watchdog option is selected)


\
\ @brief IWDG prescaler register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant IWDG_IWDG_PR_PR                                  \ Prescaler divider These bits are write access protected see . They are written by software to select the prescaler divider feeding the counter clock. PVU bit of the must be reset in order to be able to change the prescaler divider. Note: Reading this register returns the prescaler value from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the PVU bit in the status register (IWDG_SR) is reset.


\
\ @brief IWDG reload register
\ Address offset: 0x08
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG_IWDG_RLR_RL                                 \ Watchdog counter reload value These bits are write access protected see . They are written by software to define the value to be loaded in the watchdog counter each time the value 0xAAAA is written in the . The watchdog counter counts down from this value. The timeout period is a function of this value and the clock prescaler. Refer to the datasheet for the timeout information. The RVU bit in the must be reset to be able to change the reload value. Note: Reading this register returns the reload value from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing on it. For this reason the value read from this register is valid only when the RVU bit in the status register (IWDG_SR) is reset.


\
\ @brief IWDG status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IWDG_IWDG_SR_PVU                                 \ Watchdog prescaler value update This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the VDD voltage domain (takes up to five LSI cycles). Prescaler value can be updated only when PVU bit is reset.
$00000002 constant IWDG_IWDG_SR_RVU                                 \ Watchdog counter reload value update This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to five LSI cycles). Reload value can be updated only when RVU bit is reset.
$00000004 constant IWDG_IWDG_SR_WVU                                 \ Watchdog counter window value update This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to five LSI cycles). Window value can be updated only when WVU bit is reset.


\
\ @brief IWDG window register
\ Address offset: 0x10
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG_IWDG_WINR_WIN                               \ Watchdog counter window value These bits are write access protected, see , they contain the high limit of the window value to be compared with the downcounter. To prevent a reset, the downcounter must be reloaded when its value is lower than the window register value and greater than 0x0 The WVU bit in the must be reset in order to be able to change the reload value. Note: Reading this register returns the reload value from the VDD voltage domain. This value may not be valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the WVU bit in the (IWDG_SR) is reset.


\
\ @brief IWDG register block
\
$40003000 constant IWDG_IWDG_KR   \ offset: 0x00 : IWDG key register
$40003004 constant IWDG_IWDG_PR   \ offset: 0x04 : IWDG prescaler register
$40003008 constant IWDG_IWDG_RLR  \ offset: 0x08 : IWDG reload register
$4000300c constant IWDG_IWDG_SR   \ offset: 0x0C : IWDG status register
$40003010 constant IWDG_IWDG_WINR  \ offset: 0x10 : IWDG window register

